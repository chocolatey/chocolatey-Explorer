﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Chocolatey" file="LocalizeExtension.cs">
//   Copyright 2014 - Present Rob Reynolds, the maintainers of Chocolatey, and RealDimensions Software, LLC
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Windows.Data;

namespace ChocolateyGui.Common.Windows.Utilities.Extensions
{
    public sealed class LocalizeExtension : Binding
    {
        public LocalizeExtension(string name)
            : base("[" + name + "]")
        {
            Mode = BindingMode.OneWay;
            Source = TranslationSource.Instance;
        }
    }
}