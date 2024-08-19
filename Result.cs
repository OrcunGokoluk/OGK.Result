using System.Text.Json;
using System.Text.Json.Serialization;

namespace OGK.Result;
public sealed class Result<T>
{
    public T? Data { get; set; }
    public string ErrorMessages { get; set; }
    public bool IsSuccessful { get; set; }

    [JsonIgnore]
    public int StatusCode { get; set; }

    private Result(T data)
    {
        Data = data;
        IsSuccessful = true;
        StatusCode = 200;
    }

    private Result(string badMessage, int statusCode = 400)
    {
        ErrorMessages = badMessage;
        IsSuccessful = false;
        StatusCode = statusCode;
    }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
    public static Result<T> SendSuccess(T data)
    {
        return new Result<T>(data);
    }
    public static Result<T> SendFailure(string badMessage)
    {
        return new Result<T>(badMessage, 500);
    }
}
