﻿//
// Copyright (C) 1993-1996 Id Software, Inc.
// Copyright (C) 2019-2020 Nobuaki Tanaka
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//



using System;

namespace ManagedDoom.Video
{
    public interface IVideo
    {
        public void Render(Doom doom, Fixed frameFrac);
        public void InitializeWipe();
        public bool HasFocus();

        public int MaxWindowSize { get; }
        public int WindowSize { get; set; }

        public bool DisplayMessage { get; set; }

        public int MaxGammaCorrectionLevel { get; }
        public int GammaCorrectionLevel { get; set; }

        public int WipeBandCount { get; }
        public int WipeHeight { get; }
    }
}
