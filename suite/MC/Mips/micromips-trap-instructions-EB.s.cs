# CS_ARCH_MIPS, CS_MODE_MIPS32+CS_MODE_MICRO+CS_MODE_BIG_ENDIAN, None
0x01,0x28,0x00,0x3c = teq $t0, $t1
0x01,0x28,0x02,0x3c = tge $t0, $t1
0x01,0x28,0x04,0x3c = tgeu $t0, $t1
0x01,0x28,0x08,0x3c = tlt $t0, $t1
0x01,0x28,0x0a,0x3c = tltu $t0, $t1
0x01,0x28,0x0c,0x3c = tne $t0, $t1
0x41,0xc9,0x45,0x67 = teqi $t1, 17767
0x41,0x29,0x45,0x67 = tgei $t1, 17767
0x41,0x69,0x45,0x67 = tgeiu $t1, 17767
0x41,0x09,0x45,0x67 = tlti $t1, 17767
0x41,0x49,0x45,0x67 = tltiu $t1, 17767
0x41,0x89,0x45,0x67 = tnei $t1, 17767
