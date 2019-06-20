using System;
using System.Collections.Generic;
using System.Text;

namespace Hinded
{
	class Keskmine
	{
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
	}
}
