﻿namespace Nikon_Patch
{
    class D800_0101 : Firmware
    {
        Patch[] patch_mov_len = {
              new Patch(1, 0x225B0, new byte[] { 0xE4, 0x01 }, new byte[] { 0xE0, 0x01 }), // mov 1/3
              new Patch(1, 0x2275c, new byte[] { 0xE4, 0x02 }, new byte[] { 0xE0, 0x02 }), // mov 2/3
              new Patch(1, 0x238EE, new byte[] { 0xE4, 0x0A }, new byte[] { 0xE0, 0x0A }), // mov 3/3
                                 };

        public D800_0101()
        {
            p = new Package();
            Model = "D800";
            Version = "1.01";

            //Patches.Add(new PatchSet(PatchLevel.Beta, "Remove Time Based Video Restrictions", patch_mov_len));
        }
    }

    class D800_0102 : Firmware
    {
        Patch[] patch_1080_36mbps = {
            new Patch(1, 0x21E36, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E3C, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E4A, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E68, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E76, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EB4, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21EC2, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };

        Patch[] patch_1080_54mbps = {
            new Patch(1, 0x21E36, new byte[] { 0x01 } , new byte[] { 0x03 } ),
            new Patch(1, 0x21E3C, new byte[] { 0x01 } , new byte[] { 0x03 } ),
            new Patch(1, 0x21E4A, new byte[] { 0x00, 0xB7, 0x1B } , new byte[] { 0x01, 0x6E, 0x36 } ),
            new Patch(1, 0x21E50, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62, new byte[] { 0x01 } , new byte[] { 0x03 } ),
            new Patch(1, 0x21E68, new byte[] { 0x01 } , new byte[] { 0x03 } ),
            new Patch(1, 0x21E76, new byte[] { 0x00, 0xB7, 0x1B } , new byte[] { 0x01, 0x6E, 0x36 } ),
            new Patch(1, 0x21E7C, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE, new byte[] { 0x01 } , new byte[] { 0x03 } ),
            new Patch(1, 0x21EB4, new byte[] { 0x01 } , new byte[] { 0x03 } ),
            new Patch(1, 0x21EC2, new byte[] { 0x00, 0xB7, 0x1B } , new byte[] { 0x01, 0x6E, 0x36 } ),
            new Patch(1, 0x21EC8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };

        Patch[] patch_1080_64mbps = {
            new Patch(1, 0x21E36, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21E3C, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21E4A, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21E68, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21E76, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21EB4, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21EC2, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };


        public D800_0102()
        {
            p = new Package();
            Model = "D800";
            Version = "1.02";

            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 36mbps Bit-rate NQ old HQ", patch_1080_36mbps, patch_1080_54mbps, patch_1080_64mbps));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 54mbps Bit-rate NQ old HQ", patch_1080_54mbps, patch_1080_36mbps, patch_1080_64mbps));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 64mbps Bit-rate NQ old HQ", patch_1080_64mbps, patch_1080_36mbps, patch_1080_54mbps));

        }
    }


    class D800_0110 : Firmware
    {
        Patch[] patch_1080_36mbps = {
            new Patch(1, 0x21E36 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E3C - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E4A - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E68 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E76 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EB4 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21EC2 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };

        Patch[] patch_1080_54mbps = {
            new Patch(1, 0x21E36 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E3C - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E4A - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E68 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E76 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EB4 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21EC2 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };

        Patch[] patch_1080_64mbps = {
            new Patch(1, 0x21E36 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21E3C - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21E4A - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21E68 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21E76 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21EB4 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21EC2 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };

        Patch[] patch_1080_64_36_mbps = {
            new Patch(1, 0x21E36 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21E3C - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21E4A - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21E68 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21E76 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21EB4 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21EC2 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x02, 0x31, 0x2D, 0x00} ),
                                  };

        Patch[] patch_Language_Fix = {
            new Patch(1, 0x3EA1A6, new byte[] { 0xE2, 0x08 }, new byte[] { 0xE0, 0x08 }),
            new Patch(1, 0x3EEE76, new byte[] { 0xE2, 0x11 }, new byte[] { 0xE0, 0x11 }),
                          };

        Patch[] patch_dark_current_menu = {
            new Patch(1, 0x4A7BA8, new byte[] { 0x84, 0xE2, 0x3B, 0x37 } , new byte[] { 0x00, 0x5B, 0x70, 0x00 } ),
            new Patch(1, 0x4A7BAD, new byte[] { 0x94, 0xC0, 0x1D, 0x82, 0x4D, 0xE2, 0x02, 0x91, 0x40, 0xE0, 0x01, 0x81, 0xB0 } , new byte[] { 0x00, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0 } ),
            new Patch(1, 0x577000, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } , new byte[] { 0x9F, 0x8D, 0x85, 0xA4, 0xE7, 0x2C, 0x9B, 0x00, 0x4E, 0x5A, 0xC0, 0x04, 0x11, 0x04, 0xA4, 0x40, 0x11, 0x04, 0x9B, 0x00, 0x4F, 0x5E, 0x11, 0x04, 0xA4, 0x40, 0x11, 0x04, 0x9B, 0x00, 0x50, 0x62, 0x11, 0x04, 0xA4, 0x40, 0x11, 0x04, 0x9B, 0x04, 0x80, 0x00, 0x9B, 0x00, 0x05, 0xEA, 0x11, 0x04, 0x9B, 0x00, 0x06, 0x1E, 0x11, 0x04, 0x9B, 0x00, 0x06, 0x52, 0x11, 0x04, 0x9F, 0x8D, 0x84, 0xE2, 0x3B, 0xC1, 0x91, 0x2D, 0x9F, 0x80, 0x00, 0x4E, 0x7B, 0xB6, 0x97, 0x00 } ),
            new Patch(1, 0xAFF0C7, new byte[] { 0x4A, 0x50, 0x45, 0x47, 0x20, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x69, 0x6F, 0x6E } , new byte[] { 0x41, 0x73, 0x74, 0x72, 0x6F, 0x70, 0x68, 0x6F, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79 } ),
            new Patch(1, 0xAFF0E4, new byte[] { 0x4F, 0x70, 0x74, 0x69, 0x6D, 0x61, 0x6C, 0x20, 0x71, 0x75, 0x61, 0x6C, 0x69, 0x74, 0x79 } , new byte[] { 0x53, 0x65, 0x6E, 0x73, 0x6F, 0x72, 0x20, 0x52, 0x41, 0x57, 0x20, 0x4F, 0x6E, 0x21, 0x20 } ),
            new Patch(1, 0xB006F6, new byte[] { 0x4A, 0x50, 0x45, 0x47, 0x20, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x69, 0x6F, 0x6E } , new byte[] { 0x41, 0x73, 0x74, 0x72, 0x6F, 0x70, 0x68, 0x6F, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79 } ),
            new Patch(1, 0xB083AE, new byte[] { 0x43, 0x68, 0x6F, 0x6F, 0x73, 0x65, 0x20, 0x68, 0x6F, 0x77, 0x20, 0x4A, 0x50, 0x45, 0x47, 0x20, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x73 } , new byte[] { 0x54, 0x6F, 0x20, 0x72, 0x65, 0x63, 0x6F, 0x72, 0x64, 0x20, 0x75, 0x6E, 0x63, 0x6F, 0x6F, 0x6B, 0x65, 0x64, 0x20, 0x52, 0x41, 0x57 } ),
            new Patch(1, 0xB083C5, new byte[] { 0x28, 0x66, 0x69, 0x6E, 0x65, 0x2C, 0x20, 0x6E, 0x6F, 0x72 } , new byte[] { 0x66, 0x72, 0x6F, 0x6D, 0x20, 0x74, 0x68, 0x65, 0x20, 0x69 } ),
            new Patch(1, 0xB083D1, new byte[] { 0x6C, 0x2C, 0x20, 0x0A, 0x61 } , new byte[] { 0x67, 0x65, 0x0A, 0x73, 0x65 } ),
            new Patch(1, 0xB083D7, new byte[] { 0x64, 0x20, 0x62, 0x61, 0x73, 0x69, 0x63, 0x29, 0x20, 0x77, 0x69, 0x6C, 0x6C, 0x20, 0x62, 0x65, 0x20, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x65, 0x64, 0x2E } , new byte[] { 0x73, 0x6F, 0x72, 0x20, 0x66, 0x6F, 0x72, 0x20, 0x61, 0x73, 0x74, 0x72, 0x6F, 0x70, 0x68, 0x6F, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79, 0x2E, 0x20, 0x20, 0x20 } ),
            new Patch(1, 0xB08403, new byte[] { 0x41, 0x6C, 0x6C, 0x20 } , new byte[] { 0x53, 0x65, 0x74, 0x74 } ),
            new Patch(1, 0xB08408, new byte[] { 0x6D, 0x61, 0x67, 0x65, 0x73, 0x20, 0x61 } , new byte[] { 0x6E, 0x67, 0x20, 0x62, 0x65, 0x66, 0x6F } ),
            new Patch(1, 0xB08411, new byte[] { 0x20, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73 } , new byte[] { 0x64, 0x20, 0x66, 0x69, 0x72, 0x6D, 0x77, 0x61, 0x72 } ),
            new Patch(1, 0xB0841B, new byte[] { 0x64, 0x20, 0x0A, 0x74, 0x6F, 0x20, 0x61, 0x72, 0x6F, 0x75, 0x6E, 0x64, 0x20, 0x74, 0x68, 0x65, 0x20, 0x73, 0x61, 0x6D, 0x65, 0x20, 0x66, 0x69, 0x6C, 0x65 } , new byte[] { 0x0A, 0x75, 0x70, 0x64, 0x61, 0x74, 0x65, 0x20, 0x69, 0x73, 0x20, 0x6B, 0x65, 0x70, 0x74, 0x20, 0x75, 0x6E, 0x63, 0x68, 0x61, 0x6E, 0x67, 0x65, 0x64, 0x2E } ),
            new Patch(1, 0xB08436, new byte[] { 0x73, 0x69, 0x7A, 0x65, 0x2E } , new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20 } ),
            new Patch(1, 0xB0843C, new byte[] { 0x4F, 0x70, 0x74, 0x69, 0x6D, 0x61, 0x6C, 0x20, 0x71, 0x75, 0x61, 0x6C, 0x69, 0x74, 0x79, 0x3A, 0x20, 0x50, 0x72, 0x69 } , new byte[] { 0x53, 0x65, 0x6E, 0x73, 0x6F, 0x72, 0x20, 0x52, 0x41, 0x57, 0x20, 0x4F, 0x6E, 0x21, 0x3A, 0x20, 0x54, 0x65, 0x6D, 0x70 } ),
            new Patch(1, 0xB08452, new byte[] { 0x69, 0x74, 0x79, 0x20, 0x69, 0x73, 0x20, 0x67, 0x69, 0x76, 0x65, 0x6E } , new byte[] { 0x61, 0x72, 0x69, 0x6C, 0x79, 0x20, 0x65, 0x6E, 0x61, 0x62, 0x6C, 0x65 } ),
            new Patch(1, 0xB0845F, new byte[] { 0x74, 0x6F, 0x20, 0x0A, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x20, 0x71, 0x75, 0x61, 0x6C, 0x69, 0x74, 0x79, 0x2E, 0x20, 0x46, 0x69, 0x6C, 0x65, 0x20, 0x73, 0x69, 0x7A, 0x65, 0x73, 0x20, 0x6D, 0x61, 0x79 } , new byte[] { 0x73, 0x65, 0x6E, 0x73, 0x6F, 0x72, 0x0A, 0x52, 0x41, 0x57, 0x2E, 0x20, 0x50, 0x6F, 0x77, 0x65, 0x72, 0x2F, 0x4D, 0x65, 0x74, 0x65, 0x72, 0x69, 0x6E, 0x67, 0x20, 0x6F, 0x66, 0x66, 0x20, 0x74, 0x6F } ),
            new Patch(1, 0xB08481, new byte[] { 0x64, 0x69, 0x66, 0x66, 0x65, 0x72, 0x2E } , new byte[] { 0x72, 0x65, 0x73, 0x65, 0x74, 0x2E, 0x20 } ),
                           };

        public D800_0110()
        {
            p = new Package();
            Model = "D800";
            Version = "1.10";

            Patches.Add(new PatchSet(PatchLevel.Released, "Multi-Language Support", patch_Language_Fix));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 36mbps Bit-rate NQ old HQ", patch_1080_36mbps, patch_1080_54mbps, patch_1080_64mbps, patch_1080_64_36_mbps));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 54mbps Bit-rate NQ old HQ", patch_1080_54mbps, patch_1080_36mbps, patch_1080_64mbps, patch_1080_64_36_mbps));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 64mbps Bit-rate NQ old HQ", patch_1080_64mbps, patch_1080_36mbps, patch_1080_54mbps, patch_1080_64_36_mbps));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 64mbps, NQ 36mbps", patch_1080_64_36_mbps, patch_1080_64mbps, patch_1080_36mbps, patch_1080_54mbps));

            Patches.Add(new PatchSet(PatchLevel.Released, "True Dark Current - Menu based", patch_dark_current_menu));
        }
    }



    /* D800E ---------------------------------------------------------------*/

    class D800E_0101 : Firmware
    {

        public D800E_0101()
        {
            p = new Package();
            Model = "D800E";
            Version = "1.01";
        }
    }

    class D800E_0102 : Firmware
    {
        Patch[] patch_1080_36mbps = {
            new Patch(1, 0x21E36, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E3C, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E4A, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E68, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E76, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EB4, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21EC2, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };

        Patch[] patch_1080_54mbps = {
            new Patch(1, 0x21E36, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E3C, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E4A, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E68, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E76, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EB4, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21EC2, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };

        Patch[] patch_1080_64mbps = {
            new Patch(1, 0x21E36, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21E3C, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21E4A, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21E68, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21E76, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21EB4, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21EC2, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };


        public D800E_0102()
        {
            p = new Package();
            Model = "D800E";
            Version = "1.02";

            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 36mbps Bit-rate NQ old HQ", patch_1080_36mbps, patch_1080_54mbps, patch_1080_64mbps));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 54mbps Bit-rate NQ old HQ", patch_1080_54mbps, patch_1080_36mbps, patch_1080_64mbps));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 64mbps Bit-rate NQ old HQ", patch_1080_64mbps, patch_1080_36mbps, patch_1080_54mbps));
        }
    }

    class D800E_0110 : Firmware
    {
        Patch[] patch_1080_36mbps = {
            new Patch(1, 0x21E36 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E3C - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E4A - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E68 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E76 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x02, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EB4 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x02, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21EC2 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };

        Patch[] patch_1080_54mbps = {
            new Patch(1, 0x21E36 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E3C - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E4A - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E68 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21E76 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EB4 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x31, 0x2D, 0x00 } ),
            new Patch(1, 0x21EC2 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };

        Patch[] patch_1080_64mbps = {
            new Patch(1, 0x21E36 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21E3C - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21E4A - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E50 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21E62 - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21E68 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21E76 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21E7C - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00 } ),

            new Patch(1, 0x21EAE - 8, new byte[] { 0x01, 0x6E, 0x36, 0x00 } , new byte[] { 0x03, 0xd0, 0x90, 0x00 } ),
            new Patch(1, 0x21EB4 - 8, new byte[] { 0x01, 0x31, 0x2D, 0x00 } , new byte[] { 0x03, 0x93, 0x87, 0x00 } ),
            new Patch(1, 0x21EC2 - 8, new byte[] { 0x00, 0xB7, 0x1B, 0x00 } , new byte[] { 0x01, 0x6E, 0x36, 0x00 } ),
            new Patch(1, 0x21EC8 - 8, new byte[] { 0x00, 0x98, 0x96, 0x80 } , new byte[] { 0x01, 0x31, 0x2D, 0x00} ),
                                  };

		Patch[] patch_dark_current_menu = {
			new Patch(1, 0x4A7BAC, new byte[] { 0x84, 0xE2, 0x3B, 0x37, 0x97, 0x94, 0xC0, 0x1D, 0x82, 0x4D, 0xE2, 0x02, 0x91, 0x40, 0xE0, 0x01, 0x81, 0xB0 } , new byte[] { 0x00, 0x5B, 0x70, 0x00, 0x97, 0x00, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0, 0x9F, 0xA0 } ),
			new Patch(1, 0x577000, new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF } , new byte[] { 0x9F, 0x8D, 0x85, 0xA4, 0xE7, 0x2C, 0x9B, 0x00, 0x4E, 0x5A, 0xC0, 0x04, 0x11, 0x04, 0xA4, 0x40, 0x11, 0x04, 0x9B, 0x00, 0x4F, 0x5E, 0x11, 0x04, 0xA4, 0x40, 0x11, 0x04, 0x9B, 0x00, 0x50, 0x62, 0x11, 0x04, 0xA4, 0x40, 0x11, 0x04, 0x9B, 0x04, 0x80, 0x00, 0x9B, 0x00, 0x05, 0xEA, 0x11, 0x04, 0x9B, 0x00, 0x06, 0x1E, 0x11, 0x04, 0x9B, 0x00, 0x06, 0x52, 0x11, 0x04, 0x9F, 0x8D, 0x84, 0xE2, 0x3B, 0xC1, 0x91, 0x2D, 0x97, 0x20 } ),
			new Patch(1, 0xAFF0C7, new byte[] { 0x4A, 0x50, 0x45, 0x47, 0x20, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x69, 0x6F, 0x6E } , new byte[] { 0x41, 0x73, 0x74, 0x72, 0x6F, 0x70, 0x68, 0x6F, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79 } ),
			new Patch(1, 0xAFF0E4, new byte[] { 0x4F, 0x70, 0x74, 0x69, 0x6D, 0x61, 0x6C, 0x20, 0x71, 0x75, 0x61, 0x6C, 0x69, 0x74, 0x79 } , new byte[] { 0x53, 0x65, 0x6E, 0x73, 0x6F, 0x72, 0x20, 0x52, 0x41, 0x57, 0x20, 0x4F, 0x6E, 0x21, 0x20 } ),
			new Patch(1, 0xB006F6, new byte[] { 0x4A, 0x50, 0x45, 0x47, 0x20, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x69, 0x6F, 0x6E } , new byte[] { 0x41, 0x73, 0x74, 0x72, 0x6F, 0x70, 0x68, 0x6F, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79 } ),
			new Patch(1, 0xB083AE, new byte[] { 0x43, 0x68, 0x6F, 0x6F, 0x73, 0x65, 0x20, 0x68, 0x6F, 0x77, 0x20, 0x4A, 0x50, 0x45, 0x47, 0x20, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x73, 0x20, 0x28, 0x66, 0x69, 0x6E, 0x65, 0x2C, 0x20, 0x6E, 0x6F, 0x72 } , new byte[] { 0x54, 0x6F, 0x20, 0x72, 0x65, 0x63, 0x6F, 0x72, 0x64, 0x20, 0x75, 0x6E, 0x63, 0x6F, 0x6F, 0x6B, 0x65, 0x64, 0x20, 0x52, 0x41, 0x57, 0x20, 0x66, 0x72, 0x6F, 0x6D, 0x20, 0x74, 0x68, 0x65, 0x20, 0x69 } ),
			new Patch(1, 0xB083D1, new byte[] { 0x6C, 0x2C, 0x20, 0x0A, 0x61, 0x6E, 0x64, 0x20, 0x62, 0x61, 0x73, 0x69, 0x63, 0x29, 0x20, 0x77, 0x69, 0x6C, 0x6C, 0x20, 0x62, 0x65, 0x20, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x65, 0x64, 0x2E } , new byte[] { 0x67, 0x65, 0x0A, 0x73, 0x65, 0x6E, 0x73, 0x6F, 0x72, 0x20, 0x66, 0x6F, 0x72, 0x20, 0x61, 0x73, 0x74, 0x72, 0x6F, 0x70, 0x68, 0x6F, 0x74, 0x6F, 0x67, 0x72, 0x61, 0x70, 0x68, 0x79, 0x2E, 0x20, 0x20, 0x20 } ),
			new Patch(1, 0xB08403, new byte[] { 0x41, 0x6C, 0x6C, 0x20, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x73, 0x20, 0x61 } , new byte[] { 0x53, 0x65, 0x74, 0x74, 0x69, 0x6E, 0x67, 0x20, 0x62, 0x65, 0x66, 0x6F } ),
			new Patch(1, 0xB08411, new byte[] { 0x20, 0x63, 0x6F, 0x6D, 0x70, 0x72, 0x65, 0x73, 0x73, 0x65, 0x64, 0x20, 0x0A, 0x74, 0x6F, 0x20, 0x61, 0x72, 0x6F, 0x75, 0x6E, 0x64, 0x20, 0x74, 0x68, 0x65, 0x20, 0x73, 0x61, 0x6D, 0x65, 0x20, 0x66, 0x69, 0x6C, 0x65, 0x20, 0x73, 0x69, 0x7A, 0x65, 0x2E, 0x02, 0x4F, 0x70, 0x74, 0x69, 0x6D, 0x61, 0x6C, 0x20, 0x71, 0x75, 0x61, 0x6C, 0x69, 0x74, 0x79, 0x3A, 0x20, 0x50, 0x72, 0x69 } , new byte[] { 0x64, 0x20, 0x66, 0x69, 0x72, 0x6D, 0x77, 0x61, 0x72, 0x65, 0x0A, 0x75, 0x70, 0x64, 0x61, 0x74, 0x65, 0x20, 0x69, 0x73, 0x20, 0x6B, 0x65, 0x70, 0x74, 0x20, 0x75, 0x6E, 0x63, 0x68, 0x61, 0x6E, 0x67, 0x65, 0x64, 0x2E, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x02, 0x53, 0x65, 0x6E, 0x73, 0x6F, 0x72, 0x20, 0x52, 0x41, 0x57, 0x20, 0x4F, 0x6E, 0x21, 0x3A, 0x20, 0x54, 0x65, 0x6D, 0x70 } ),
			new Patch(1, 0xB08452, new byte[] { 0x69, 0x74, 0x79, 0x20, 0x69, 0x73, 0x20, 0x67, 0x69, 0x76, 0x65, 0x6E, 0x20, 0x74, 0x6F, 0x20, 0x0A, 0x69, 0x6D, 0x61, 0x67, 0x65, 0x20, 0x71, 0x75, 0x61, 0x6C, 0x69, 0x74, 0x79, 0x2E, 0x20, 0x46, 0x69, 0x6C, 0x65, 0x20, 0x73, 0x69, 0x7A, 0x65, 0x73, 0x20, 0x6D, 0x61, 0x79, 0x20, 0x64, 0x69, 0x66, 0x66, 0x65, 0x72, 0x2E } , new byte[] { 0x61, 0x72, 0x69, 0x6C, 0x79, 0x20, 0x65, 0x6E, 0x61, 0x62, 0x6C, 0x65, 0x20, 0x73, 0x65, 0x6E, 0x73, 0x6F, 0x72, 0x0A, 0x52, 0x41, 0x57, 0x2E, 0x20, 0x50, 0x6F, 0x77, 0x65, 0x72, 0x2F, 0x4D, 0x65, 0x74, 0x65, 0x72, 0x69, 0x6E, 0x67, 0x20, 0x6F, 0x66, 0x66, 0x20, 0x74, 0x6F, 0x20, 0x72, 0x65, 0x73, 0x65, 0x74, 0x2E, 0x20 } ),
		};

 
        public D800E_0110()
        {
            p = new Package();
            Model = "D800E";
            Version = "1.10";

            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 36mbps Bit-rate NQ old HQ", patch_1080_36mbps, patch_1080_54mbps, patch_1080_64mbps));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 54mbps Bit-rate NQ old HQ", patch_1080_54mbps, patch_1080_36mbps, patch_1080_64mbps));
            Patches.Add(new PatchSet(PatchLevel.Released, "Video 1080 HQ 64mbps Bit-rate NQ old HQ", patch_1080_64mbps, patch_1080_36mbps, patch_1080_54mbps));
			Patches.Add(new PatchSet(PatchLevel.Beta, "True Dark Current - Menu based", patch_dark_current_menu));
		}
	}

}
