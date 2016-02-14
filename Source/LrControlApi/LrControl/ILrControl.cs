﻿namespace LrControlApi.LrControl
{
    public interface ILrControl
    {
        /// <summary>
        ///     Gets the running plugin version (major.minor)
        /// </summary>
        /// <returns></returns>
        string GetApiVersion();
    }
}