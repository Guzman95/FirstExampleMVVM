using Excercise__mvvm.Connectors;
using Excercise__mvvm.Core;
using Excercise__mvvm.Core.Commands;
using Excercise__mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Excercise__mvvm.ModelsViews
{
    public class PersonaViewModel : IGeneric
    {

        private PersonaCollection _listaPersonas;
        public PersonaCollection ListaPersonas
        {
            get { return _listaPersonas; }
            set 
            { 
                _listaPersonas = value;
                RaisePropertyChanged("ListaPersonas");
            }
                
        }
        private Persona _currentPersona;
        public Persona CurrentPersona
        {
            get { return _currentPersona; }
            set 
            { 
                _currentPersona = value;
                RaisePropertyChanged("CurrentPersona");
            }
        }
        private ICommand _listarPersonasCommands;
        public ICommand ListarPersonasCommand
        {
            get
            {
                if(_listarPersonasCommands == null)
                {
                    _listarPersonasCommands = new RelayCommand(new Action(ListarPersonas));
                }
                return _listarPersonasCommands;
            }
        }
        private void ListarPersonas()
        {
            ListaPersonas = App.Conector.listarPersonas();
            
        }
        private ICommand _verInfoCommand;
        public ICommand VerInfoCommand
        {

            get
            {
                if (_verInfoCommand == null)
                {
                    _verInfoCommand = new RelayCommand(new Action(InformacionPersona));
                }
                return _verInfoCommand;
            }

        }
        private void InformacionPersona()
        {
            if(CurrentPersona == null)
            {
                MessageBox.Show("No se ha seleccionado a ninguna persona");
            }
            else
            {
                MessageBox.Show("el id de la persona "+CurrentPersona.Id.ToString()+" y su nombre es: "+ CurrentPersona.Nombre);

            }
            
        }

    }

}
