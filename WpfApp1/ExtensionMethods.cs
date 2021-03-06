﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;
namespace CowboyCafe.Extensions
{
    /// <summary>
    /// Find the first ancestor in the visual tree that has the specified type,
    /// or null if no ancestor is found
    /// </summary>
    public static class ExtensionMethods
    {
        public static T FindAncestor<T>(this DependencyObject obj) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(obj);

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return FindAncestor<T>(parent);
        }
    }
}
