namespace LostTech.App.DataBinding
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using JetBrains.Annotations;

    /// <summary>
    /// Simple class, that implements <see cref="INotifyPropertyChanged"/>
    /// </summary>
    public class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Invoke, when own property value changes.
        /// </summary>
        /// <param name="propertyName">Name of the property, whose value changes</param>
        [NotifyPropertyChangedInvocator]
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null!) {
            if (propertyName is null) throw new ArgumentNullException(nameof(propertyName));
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
