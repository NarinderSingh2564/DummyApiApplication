namespace DummyApiApplication.Web.Model
{
    public class ApiResponseModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public object Response { get; set; }
    }
}
