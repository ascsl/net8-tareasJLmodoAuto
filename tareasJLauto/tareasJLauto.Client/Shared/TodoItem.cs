namespace tareasJLauto.Shared;

public enum TodoStatus
{
    Planificada,
    Iniciada,
    EnCurso,
    Completada
}

public class TodoItem
{

    public TodoItem(string descr)
    {
        Title = descr;
        Status = TodoStatus.Planificada;
        IsBlocked = false;
    }

    public string? Title { get; set; }
    public TodoStatus Status { get; set; }
    public bool IsBlocked { get; set; }
    public bool IsSelected { get; set; }
}
