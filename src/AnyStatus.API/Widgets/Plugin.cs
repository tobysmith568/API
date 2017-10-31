﻿namespace AnyStatus.API
{
    /// <summary>
    /// Base class for all widgets.
    /// </summary>
    public abstract class Plugin : Item
    {
        protected Plugin() : base(aggregate: false) { }

        protected Plugin(bool aggregate) : base(aggregate) { }
    }
}
