
int[] a={2,3,7};
int n=3;
  int max = a[0];  // максимальный элемент
            for (int i = 1; i < n; ++i)
                if (a[i] > max) max = a[i];
            Console.WriteLine("Максимальный элемент=" + max);

