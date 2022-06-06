namespace LostTech.App.DataBinding
{
    using System;

    public static class CopyableExtensions
    {
        /// <summary>
        /// Make a copy of a specified object, if it is copyable. Otherwise throw.
        /// </summary>
        /// <typeparam name="T">Type of the copied object</typeparam>
        /// <param name="obj">Object to copy</param>
        public static T? Copy<T>(this T? obj)
            where T: class
        {
            if (obj is null)
                return null;
            if (obj is ICopyable<T> copyable)
                return copyable.Copy();

            throw new NotSupportedException();
        }
    }
}
