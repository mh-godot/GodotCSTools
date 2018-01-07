﻿using System;

namespace GodotCSTools
{
    /// <summary>
    /// Sets the value of a field to the node at the given path.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class NodePathAttribute : Attribute
    {
        public string NodePath
        {
            get;
            set;
        }

        /// <summary>
        /// Constructs a <see cref="NodePathAttribute"/>
        /// </summary>
        /// <param name="path">The path to the node, relative to the current node.</param>
        public NodePathAttribute(string path)
        {
            this.NodePath = path;
        }
    }
}
