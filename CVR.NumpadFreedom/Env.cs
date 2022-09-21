using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVR.NumpadFreedomMod; 
internal class Env {
  MelonPreferences_Category _category;
  MelonPreferences_Entry<bool> _enabledEntry;

  public static bool Enabled { get; private set; } = true;

  public Env() {
    _category = MelonPreferences.CreateCategory("CVR_NumpadFreedom");
    _enabledEntry = _category.CreateEntry("Enabled", true);
    _enabledEntry.OnValueChanged += OnEnabledEntryChanged;
  }
  ~Env() {
    _enabledEntry.OnValueChanged -= OnEnabledEntryChanged;
  }

  void OnEnabledEntryChanged(bool oldValue, bool newValue) {
    Enabled = newValue;
  }
}
