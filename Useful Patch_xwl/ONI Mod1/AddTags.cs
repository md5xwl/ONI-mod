﻿// Decompiled with JetBrains decompiler
// Type: Useful_Patch.AddTags
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

namespace Useful_Patch
{
  public static class AddTags
  {
    public static void AddStrings(Tag tag, string name) => Strings.Add("STRINGS.MISC.TAGS." + tag.Name.ToUpperInvariant(), name);
  }
}
