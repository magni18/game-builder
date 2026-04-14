public interface ISessionElements
{
    public int Id { get; set; }

    public Action? OnElementChanged { get; set; }

    public Action? OnElementDeleted { get; set; }

    public Action? OnElementAdded { get; set; }

    public Action? OnElementMoved { get; set; }

    public Action? OnElementSelected { get; set; }

    public Action? OnElementDeselected { get; set; }

    public Action? OnElementDuplicated { get; set; }
}