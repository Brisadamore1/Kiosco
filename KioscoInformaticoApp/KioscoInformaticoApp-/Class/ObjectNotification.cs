using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp_.Class
{
    // La clase ObjectNotification es una clase abstracta que implementa la interfaz INotifyPropertyChanged. Esta clase sirve como base para otras clases que necesitarán notificar cuando alguna de sus propiedades cambien.
    public abstract class ObjectNotification : INotifyPropertyChanged
    {
        /* Clase abstracta ObjectNotification: Esta es una clase abstracta, lo que significa que no se puede instanciar directamente, pero otras clases pueden heredar de ella.
        El propósito principal de esta clase es proveer una implementación común del mecanismo de notificación de cambio de propiedades para cualquier clase que herede de ella. */
        public event PropertyChangedEventHandler PropertyChanged;

        //CallerMemberName nos devuelve el nombre de la propiedad que fue modificada
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
