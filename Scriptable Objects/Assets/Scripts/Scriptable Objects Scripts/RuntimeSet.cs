﻿using UnityEngine;
using System.Collections.Generic;

namespace Scriptable_Objects_Scripts {
    
    public abstract class RuntimeSet<T> : ScriptableObject {
        public List<T> Items = new List<T>();
        
        public void Add(T t) {
            if (!Items.Contains(t)) {
                Items.Add(t);
            }
        }

        public void Remove(T t) {
            if (Items.Contains(t)) {
                Items.Remove(t);
            }
        }
    }
}