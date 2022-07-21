using System;
using System.Collections.Generic;
using System.Text;

namespace practica2JoseMeroQ
{
    public class Unsubcripcion: IDisposable
    {
               private readonly List<IObserver<Aplicacion>> observers;

    public List<Aplicacion> aplicacions { get; set; }

    public Unsubcripcion( List<IObservable<Aplicacion>> observers, IObserver<Aplicacion> observer)
    {
            this.observers = observers;
            this.observer = observer;
    }
}
}
