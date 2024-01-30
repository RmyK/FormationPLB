using Microsoft.AspNetCore.Components;
using MonEcole.BL;
using MonEcole.DAL.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoleServer.Pages
{
    public partial class ListEleveDisplay : ComponentBase
    {
        [Inject]
        private EleveService eleveService { get; set; }

        public List<Eleve> MesEleves { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadEleveAsync();
            return base.OnInitializedAsync();
        }

        public void LoadEleveAsync()
        {
            MesEleves = eleveService.GetAll();
        }
    }
}
