package com.company;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {

        Scanner in1 = new Scanner(System.in);
        System.out.print("Enter 1st number: ");
        double a = in1.nextDouble();
        Scanner in2 = new Scanner(System.in);
        System.out.print("Enter 2nd number: ");
        double b = in2.nextDouble();
        double c;
        double result = 0;
        Scanner sc = new Scanner(System.in);
        try {
            c = a/b;
            System.out.print("Result: " + c);
            if(a==0||b==0)
            {
                throw new Exception(" Error!");
            }
            }
        catch (Exception err)
        {
            System.out.println(err.getMessage());
        }
        finally {

        }

    }
}
