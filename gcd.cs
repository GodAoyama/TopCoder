static int Gcd(int a, int b) 
{
	if (a < b)
		return Gcd(b, a);
	int d = 0;

	do
	{
		d = a % b;
		a = b;
		b = d;
	} while (d != 0);

	return a;
}