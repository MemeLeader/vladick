int a = 6;
int b = 9;
int c = 10;

int result1 = a ^ 3 - 3 * a ^ 2 * b + 3 * a * b ^ 2 - b ^ 3;
int result2 = a ^ 3 + 3 * a ^ 2 * b + 3 * a * b ^ 2 + b ^ 3;
int result3 = (a + b) * (a ^ 2 - a * b + b ^ 2);
int result4 = (a - b) * (a ^ 2 + a * b + b ^ 2);
int result5 = (a - b) * (a + b);
int result6 = a ^ 2 - 2 * a * b + b ^ 2;
int result7 = a ^ 2 + 2 * a * b + b ^ 2;

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);
Console.WriteLine(result4);
Console.WriteLine(result5);
Console.WriteLine(result6);
Console.WriteLine(result7);


int result8 = ((a ^ 2 - 4 * a * b) / (a - a ^ 1 / 2 - a ^ c) - (a * b * c) ^ 3) / (a ^ 2 - 2 * a * b + b ^ 2);

Console.WriteLine(result8);
