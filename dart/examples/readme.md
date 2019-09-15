# Examples in Project

The following examples have been implemented in DartLang to demostrate the concepts described in [Clounce.com](https://www.clounce.com/) articles

| Concept | Library Method | Example |
|:---------|:----------------|:---------|
| [Arithmetic Mean](http://www.clounce.com/mathematics/arithmetic_mean) | import('package:clounce_math/statistics/averages.dart'); Average.arithmeticMean | dart arithmetic_mean.dart |
| [Mode](http://www.clounce.com/mathematics/mode) | import('package:clounce_math/statistics/averages.dart'); Average.mode | dart mode.dart |
| [Median](http://www.clounce.com/mathematics/median) | import('package:clounce_math/statistics/averages.dart'); Average.median | dart median.dart |
| [Geometric Mean](http://www.clounce.com/mathematics/geometric_mean) | import('package:clounce_math/statistics/averages.dart'); Average.geometricMean | dart geometric_mean.dart |
<br/><br/>

| Sequence Concept | Library Method | Example |
|:---------|:----------------|:---------|
| [Jacobsthal](https://www.clounce.com/mathematics/jacobsthal-number-sequence) | import('package:clounce_math/sequences/jacobsthal_numbers.dart'); JacobsthalNumbers.compute <br/> import('package:clounce_math/sequences/jacobsthal_numbers.dart'); JacobsthalNumbers.generate | dart jacobsthal_numbers.dart |
<br/><br/>

| Algorithm | Library Method | Example |
|:---------|:----------------|:---------|
| [Arithmetic Mean Sequence](http://www.clounce.com/mathematics/algorithm/arithmetic-mean-sequence) | import('package:clounce_math/solvers/arithmetic_mean_sequence.dart'); ArithmeticMeanSequence.solve <br /> import('package:clounce_math/solvers/arithmetic_mean_sequence.dart'); ArithmeticMeanSequence.solveForVariable | dart arithmetic_mean_sequence.dart |

*Notes:*

*- Before running the examples, make sure to download all dependencies using **pub get***
*- On Ubuntu, if the command pub is not found after installing dart use the command /usr/lib/dart/bin/pub get*