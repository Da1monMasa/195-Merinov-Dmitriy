#include <iostream>
#include <exception>
 
double divide(int, int);
 
int main()
{
    int x = 500;
    int y = 0;
    try
    {
        double z = divide(x, y);
        std::cout << z << std::endl;
    }
    catch (const std::exception& err)
    {
        std::cout << "Error!!!" << std::endl;
    }
    std::cout << "The End..." << std::endl;
    return 0;
}
 
double divide(int a, int b)
{
    if (b == 0)
        throw std::exception();
    return a / b;
}
