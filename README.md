LottoApp
========

Just a simple app to simulate a lotto game. The nifty part is the "unique" random number generator, unique in
the sense that you can't have more than one of the same number in the 6 digit array (lotto numbers), After about 3 days 
of grappling with the problem, I was finally pointed to the solution! Eureka!!

while (lottoNumbers < 6)
                {
                    number = rand.Next(1, 49);
                    if (Array.IndexOf(randValues, number) == -1)
                    {
                        randValues[lottoNumbers] = number;
                        lottoNumbers++;
                    }
                 }
                 
Beautiful, simple and elegant...
            
