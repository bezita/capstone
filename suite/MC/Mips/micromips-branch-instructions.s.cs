# CS_ARCH_MIPS, CS_MODE_MIPS32+CS_MODE_MICRO, None
0x00,0x94,0x9a,0x02 = b 1332
0xc9,0x94,0x9a,0x02 = beq $t1, $a2, 1332
0x46,0x40,0x9a,0x02 = bgez $a2, 1332
0x66,0x40,0x9a,0x02 = bgezal $a2, 1332
0x26,0x40,0x9a,0x02 = bltzal $a2, 1332
0xc6,0x40,0x9a,0x02 = bgtz $a2, 1332
0x86,0x40,0x9a,0x02 = blez $a2, 1332
0xc9,0xb4,0x9a,0x02 = bne $t1, $a2, 1332
0x60,0x40,0x9a,0x02 = bal 1332
0x06,0x40,0x9a,0x02 = bltz $a2, 1332
