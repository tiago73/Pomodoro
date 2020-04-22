using System.ComponentModel.DataAnnotations;
namespace Pomodoro.Model
{
    
    public class PomodoroConfig
    {
        [Required(ErrorMessage ="*")]
        [Range(1,60, ErrorMessage = "Tempo de duração de Pomodoro inválido. o valor o deve ser entre 1 e 60")]
        public int PomodoroDuration { get; set; }
        [Range(1, 15, ErrorMessage = "Tempo de duração de Pomodoro inválido. o valor o deve ser entre 1 e 15")]
        public int PausaCurta { get; set; }
        [Range(15, 60, ErrorMessage = "Tempo de duração de Pomodoro inválido. o valor o deve ser entre 15 e 60")]
        public int PausaLonga { get; set; }
    }
    public enum TimerType
    {
        Pomodro = 1,
        PausaCurta = 2,
        PausaLonga = 3
    }
}
