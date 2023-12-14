using Microsoft.EntityFrameworkCore;
using ProductLib.Extensions;

namespace ProductLib;

public class StaffService
    :IStaffService
{
    private readonly IStaffRepo _repo = default!;
    private DateTime? _actingDate = DateTime.Now;

    public StaffService(IStaffRepo repo) 
    { 
        _repo = repo;
    }

    public bool Exist(string key)
    {
        return _repo.GetQueryable().Any(x => x.Id == key );
    }

    public Result<string?> Create(StaffCreateReq req)
    {
        string text = "Creating Product";
        if (Exist(req.StaffKey) == true)
            return Result<string?>.Fail($"{text}: the code, {req.StaffKey}, does already exist");

        Staff entity = req.ToEntity();
        try
        {
            _repo.Create(entity);
            return Result<string?>.Success(entity.Id, $"{text}: Succeded");
        }
        catch (Exception ex)
        {
            return Result<string?>.Fail($"{text}: Failed>{ex.Message}");
        }
    }
    public Result<int> CreateRange(IEnumerable<StaffCreateReq> reqs)
    {
        string text = "Creating staffs";
        var codes = reqs.Select(x => x.StaffKey.Trim()).Distinct().ToList();
        if (codes?.Count() != reqs?.Count())
        {
            return Result<int>.Fail($"{text}: failed > there are some duplicate codes");
        }
        var entities = reqs?.Select(x => x.ToEntity()).ToList() ?? new();
        try
        {
            int effecteds = _repo.CreateRange(entities);
            return Result<int>.Success(effecteds, $"{text}: {effecteds} succeded");
        }
        catch (Exception ex)
        {
            return Result<int>.Fail($"{text}: failed > {ex.Message}");
        }
    }

    public Result<List<StaffResponse>> ReadAll()
    {
        var text = "Getting staffs";
        var actingDate = _actingDate ?? DateTime.Now;
        var result = _repo.GetQueryable().Select(x => x.ToResponse()).ToList();
        return Result<List<StaffResponse>>.Success(result, $"{text}: {result.Count} found");
    }
    public Result<StaffResponse?> Read(string key)
    {
        var text = "Getting staff";
        var actingDate = DateTime.Now;
        var entity = _repo.GetQueryable().FirstOrDefault(x => x.Id == key || x.StaffId.ToLower() == key.ToLower());
        return Result<StaffResponse?>.Success(entity?.ToResponse(), 
                                               $"{text}:{(entity != null ? "found" : "not found")} the staff with id, {key}");
    }

    public Result<string?> Update(StaffUpdateReq req)
    {
        var text = "Updating staff";
        var entity = _repo.GetQueryable().FirstOrDefault(x => (x.Id == req.Key)
                                                          || (x.StaffId.ToLower() == req.Key.ToLower()));
        if (entity == null)
            return Result<string?>.Fail($"{text}: no id/code, {req.Key}");

        entity.Copy(req);
        try
        {
            var result = _repo.Update(entity);
            return result == true ?
                      Result<string?>.Success(entity.Id, $"{text}: succeded")
                    : Result<string?>.Fail($"{text}: failed for the id/code, {req.Key}");
        }
        catch (Exception ex)
        {
            return Result<string?>.Fail($"{text}: failed > {ex.Message}");
        }
    }
    
    public Result<string?> Delete(string key)
    {
        var text = "Deleting staff";
        var entity = _repo.GetQueryable().FirstOrDefault(x => (x.Id == key)
                                                          || (x.StaffId.ToLower() == key.ToLower()));
        if (entity == null)
            return Result<string?>.Fail($"{text}: no id/code, {key}");
        try
        {
            var result = _repo.Delete(entity);
            return result == true ?
                      Result<string?>.Success(entity.Id, $"{text}: succeded")
                    : Result<string?>.Fail($"{text}: failed for the id/code, {key}");
        }
        catch (Exception ex)
        {
            return Result<string?>.Fail($"{text}: failed > {ex.Message}");
        }
    }
}
