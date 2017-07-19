namespace LostTech.App.DataBinding
{
    /// <summary>
    /// Allows making a copy of this instance
    /// </summary>
    /// <typeparam name="T">Type of the copy (usually set to self)</typeparam>
    public interface ICopyable<out T>
    {
        /// <summary>
        /// Make a copy of this instance
        /// </summary>
        T Copy();
    }
}
