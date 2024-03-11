using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel(string tittle, DateTime createdAt)
        {
            Tittle = tittle;
            CreatedAt = createdAt;
        }

        public string Tittle { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
