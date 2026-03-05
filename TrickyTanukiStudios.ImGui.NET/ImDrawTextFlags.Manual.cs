namespace ImGuiNET {
    // if this can later be turned into something just generated, that'd be preferred
    [System.Flags]
    public enum ImDrawTextFlags {
        None = 0,
        CpuFineClip = 1 << 0,
        WrapKeepBlanks = 1 << 1,
        StopOnNewLine = 1 << 2,
    }
}