# TODO
  
This is a list of shit I need to fucking fix [someone pls send help ive been at this for hours now, i keep listening to
`K1LL SOMEBODY by Tanger` on loop everytime shit fucking breaks and im so tired].
  
There is obviously *a lot* more broken than what is shown, this is just what I was able to catch and need to note for
  later for now. This list should/will be updated as I go about fixing the bindings.
  
  Currently the target for this is for Dear ImGui v1.92.6.
  
## v1.92.6 agony
  
- Fix broken types in [ImGui.NET/Generated/ImGuiNative.gen.cs](ImGui.NET/Generated/ImGuiNative.gen.cs). This
  needs to be fixed on a generator level, ***not*** by fucking hand, it should ***never*** be done by hand. Fix it in 
  the generator.
  - Find a way to change all `ImVec2_c` -> `Vector2`? [or is it `ImVec2*`? probably not this.]
    - Affects the following, currently not generating type correctly
      - [x] [ImGui.NET/Generated/ImFont.gen.cs](ImGui.NET/Generated/ImFont.gen.cs)
      - [x] [ImGui.NET/Generated/ImDrawList.gen.cs](ImGui.NET/Generated/ImDrawList.gen.cs)
  - Find a way to change all `ImVec4_c` -> `Vector4`? [or is it `ImVec4*`? probably not this.]
    - Affects the following, currently not generating type correctly
      - [x] [ImGui.NET/Generated/ImColor.gen.cs](ImGui.NET/Generated/ImColor.gen.cs)
  - Find a way to change all `ImColor_c` -> `ImColor*`
    - Affects the following, currently not generating type correctly
      - [x] [ImGui.NET/Generated/ImColor.gen.cs](ImGui.NET/Generated/ImColor.gen.cs)
  - Find a way to change all `ImTextureRef_c` ->
    `???` [I.. don't exactly know exactly what type this should be.. uh. I
    *assume* `IntPtr`?]
    - Affects the following, currently not generating type correctly
      - [x] [ImGui.NET/Generated/ImTextureData.gen.cs](ImGui.NET/Generated/ImTextureData.gen.cs)
    - Based off of the information found [here at Dear ImGui's FAQ.md, specifically the `What are 
  ImTextureID/ImTextureRef?` section](https://github.com/ocornut/imgui/blob/master/docs/FAQ.md#q-what-are-imtextureidimtextureref),
      `IntPtr` might be correct.
      - `IntPtr` is[?] correct
  

- Missing/broken types
  - Font related stuff [this one might be harder to figure out due to all of the v1.92 changes with fonts]
    - [ ] `ImDrawTextFlags`
      - Spotted being used at [ImGui.NET/Generated/ImFont.gen.cs](ImGui.NET/Generated/ImFont.gen.cs)
    - [ ] `ImFontAtlasBuilder`
      - Spotted being used
        at [ImGui.NET/Generated/ImFontAtlas.gen.cs](ImGui.NET/Generated/ImFontAtlas.gen.cs)
    - [ ] `ImFontAtlasBuilderPtr`
      - Spotted being used
        at [ImGui.NET/Generated/ImFontAtlas.gen.cs](ImGui.NET/Generated/ImFontAtlas.gen.cs)
    - [ ] `ImFontAtlasRectId`
      - Spotted being used
        at [ImGui.NET/Generated/ImFontAtlas.gen.cs](ImGui.NET/Generated/ImFontAtlas.gen.cs)
    - [ ] `ImFontLoader`
      - Spotted being used
        at [ImGui.NET/Generated/ImFontAtlas.gen.cs](ImGui.NET/Generated/ImFontAtlas.gen.cs)
    - [ ] `ImFontLoaderPtr`
      - Spotted being used
        at [ImGui.NET/Generated/ImFontAtlas.gen.cs](ImGui.NET/Generated/ImFontAtlas.gen.cs)
    - [ ] `ImGuiNative.ImFontAtlasCustomRect_destroy`
      - This might be a broken function actually?
      - Spotted being used
        at [ImGui.NET/Generated/ImFontAtlasCustomRect.gen.cs](ImGui.NET/Generated/ImFontAtlasCustomRect.gen.cs)
    - [ ] `ImGuiNative.ImFontAtlasCustomRect_IsPacked`
      - This might be a broken function actually?
      - Spotted being used
        at [ImGui.NET/Generated/ImFontAtlasCustomRect.gen.cs](ImGui.NET/Generated/ImFontAtlasCustomRect.gen.cs)

- Dependency updates
  - Find a way to update the following, since they're not updated by default
    - [ ] ImGuizmo.NET
    - [ ] ImNodes.NET
    - [ ] ImPlot.NET

- Deprecation/replacement
  - [ ] Deprecate MonoGame in ImGui.NET.SampleProgram.XNA
  - [ ] Deprecate Veldrid in ImGui.NET.SampleProgram
  - [ ] Replace with SDL3 equivalents, including Foster Framework

*there is more red, will update later, need to sleep, it is 03:42 [now 4:17 after more font stuff] at the time of 
writing and i am severely depressed.*