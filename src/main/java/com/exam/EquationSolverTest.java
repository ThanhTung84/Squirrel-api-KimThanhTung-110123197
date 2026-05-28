package com.exam;

import static org.junit.jupiter.api.Assertions.assertEquals;
import org.junit.jupiter.api.Test;

public class EquationSolverTest {

    @Test
    public void testCoNghiem() {
        // Trường hợp a != 0 (Ví dụ: 2x + 4 = 0) -> Kết quả mong đợi: "CN"
        assertEquals("CN", EquationSolver.giaiPhuongTrinhBac1(2, 4));
    }

    @Test
    public void testVoSoNghiem() {
        // Trường hợp a = 0, b = 0 (0x + 0 = 0) -> Kết quả mong đợi: "VSN"
        assertEquals("VSN", EquationSolver.giaiPhuongTrinhBac1(0, 0));
    }

    @Test
    public void testVoNghiem() {
        // Trường hợp a = 0, b != 0 (0x + 5 = 0) -> Kết quả mong đợi: "VN"
        assertEquals("VN", EquationSolver.giaiPhuongTrinhBac1(0, 5));
    }
}