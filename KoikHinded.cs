using System;
using System.Collections.Generic;
using System.Text;

namespace Hinded
{
	class KoikHinded
	{
		protected int hinne1;
		protected int hinna2; 
		protected int hinne3;
		public KoikHinded(int uusHinne1, int uusHinne2, int uusHinne3{
			hinne1 = uusHinne1;
			hinne2 = uusHinne2;
			hinne3 = uusHinne3;
			Keskmine();
		}
		public int GetHinne1() {return hinne1;}
		public int GetHinne2() {return hinne2;}
		public int GetHinne3() {return hinne3;}
		
		public void Keskmine() {
		
		int main() {
	    float mean;
	    int sum, i;
	    int n = 3;
	    int a[] = {};

	    sum = 0;

	    for(i = 0; i < n; i++) {
			sum+=a[i];
		}

	    printf("Keskmine on %f ", sum/(float)n);

		return 0;
		}
	
