package com.exam;

public class EquationSolver {
    public static String giaiPhuongTrinhBac1(double a, double b) {
        if (a != 0) {
            return "CN"; // Có nghiệm
        } else {
            if (b == 0) {
                return "VSN"; // Vô số nghiệm
            } else {
                return "VN"; // Vô nghiệm
            }
        }
    }
}