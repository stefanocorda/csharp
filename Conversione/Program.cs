﻿int x = 10;
double y = x;

float x1 = 12_000f;
int y1 = (int)x1;
// int y1b = Convert.ToInt32(x1);

int y2 = y1++;

int x2 = Convert.ToInt32("12345");

Console.WriteLine($"x = {x}, y = {y}, x1 = {x1}, y1 = {y1}, y2 = {y2}, x2 = {x2}");
