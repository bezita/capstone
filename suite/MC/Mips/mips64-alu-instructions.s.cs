# CS_ARCH_MIPS, CS_MODE_MIPS64, None
0x24,0x48,0xc7,0x00 = and $t1, $a2, $a3
0x67,0x45,0xc9,0x30 = andi $t1, $a2, 17767
0x67,0x45,0xc9,0x30 = andi $t1, $a2, 17767
0x21,0x30,0xe6,0x70 = clo $a2, $a3
0x20,0x30,0xe6,0x70 = clz $a2, $a3
0x84,0x61,0x33,0x7d = ins $s3, $t1, 6, 7
0x27,0x48,0xc7,0x00 = nor $t1, $a2, $a3
0x25,0x18,0x65,0x00 = or $v1, $3, $a1
0x67,0x45,0xa4,0x34 = ori $a0, $a1, 17767
0x67,0x45,0xc9,0x34 = ori $t1, $a2, 17767
0xc2,0x49,0x26,0x00 = rotr $t1, $a2, 7
0x46,0x48,0xe6,0x00 = rotrv $t1, $a2, $a3
0xc0,0x21,0x03,0x00 = sll $a0, $v1, 7
0x04,0x10,0xa3,0x00 = sllv $v0, $v1, $a1
0x2a,0x18,0x65,0x00 = slt $v1, $3, $a1
0x67,0x00,0x63,0x28 = slti $v1, $3, 103
0x67,0x00,0x63,0x28 = slti $v1, $3, 103
0x67,0x00,0x63,0x2c = sltiu $v1, $3, 103
0x2b,0x18,0x65,0x00 = sltu $v1, $3, $a1
0xc3,0x21,0x03,0x00 = sra $a0, $v1, 7
0x07,0x10,0xa3,0x00 = srav $v0, $v1, $a1
0xc2,0x21,0x03,0x00 = srl $a0, $v1, 7
0x06,0x10,0xa3,0x00 = srlv $v0, $v1, $a1
0x26,0x18,0x65,0x00 = xor $v1, $3, $a1
0x67,0x45,0xc9,0x38 = xori $t1, $a2, 17767
0x67,0x45,0xc9,0x38 = xori $t1, $a2, 17767
0xa0,0x30,0x07,0x7c = wsbh $a2, $a3
0x27,0x38,0x00,0x01 = not $a3, $t0
0x2c,0x48,0xc7,0x00 = dadd $t1, $a2, $a3
0x67,0x45,0xc9,0x60 = daddi $t1, $a2, 17767
0x67,0xc5,0xc9,0x64 = daddiu $t1, $a2, -15001
0x67,0x45,0xc9,0x60 = daddi $t1, $a2, 17767
0x67,0x45,0x29,0x61 = daddi $t1, $9, 17767
0x67,0xc5,0xc9,0x64 = daddiu $t1, $a2, -15001
0x67,0xc5,0x29,0x65 = daddiu $t1, $9, -15001
0x2d,0x48,0xc7,0x00 = daddu $t1, $a2, $a3
0x3a,0x4d,0x26,0x00 = drotr $t1, $a2, 20
0x3e,0x4d,0x26,0x00 = drotr32 $t1, $a2, 52
0x00,0x00,0xc7,0x70 = madd $a2, $a3
0x01,0x00,0xc7,0x70 = maddu $a2, $a3
0x04,0x00,0xc7,0x70 = msub $a2, $a3
0x05,0x00,0xc7,0x70 = msubu $a2, $a3
0x18,0x00,0x65,0x00 = mult $v1, $a1
0x19,0x00,0x65,0x00 = multu $v1, $a1
0x2f,0x20,0x65,0x00 = dsubu $a0, $v1, $a1
0x2d,0x38,0x00,0x01 = move $a3, $t0
