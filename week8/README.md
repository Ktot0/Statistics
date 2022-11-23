<script type="text/x-mathjax-config">
    MathJax.Hub.Config({
      tex2jax: {
        skipTags: ['script', 'noscript', 'style', 'textarea', 'pre'],
        inlineMath: [['\\(','\\)'], ['$', '$']],
        displayMath: [ ['$$','$$'], ["\\[","\\]"] ],
      }
    });
  </script>
  <script src="https://cdn.mathjax.org/mathjax/latest/MathJax.js?config=TeX-AMS-MML_HTMLorMML" type="text/javascript"></script>


# Week 8

## Objectives:

* Research

1. Search on the web about possible derivation of the Normal Distribution.
2. Search on the web about method to generate normal variate (eg Marsaglia method, etc.)

* Application

1. Consider R (radius), A(angle) uniform rv's and use them as random polar coordinates on a plane.
Determine the empirical distribution of the corresponding Cartesian coordinates (X,Y).

2. Search for the methods to generate Normal rv's X from uniform rv's, and simulate the following distribution: X, X², X/Y², X²/Y², X/Y .

* Research on App

1. Find in the web what are the distributions that you just simulated.


## Assignment
### Research

1. The Normal distribution can be obtained from approximations of the binomial distribution (de Moivre), linear regression (Gauss), and the central limit theorem.
 
    #### de Moivre: 
    
    The probability mass function of the random number of "successes" observed in a series of $n$ independent Bernoulli trials, each having probability $p$ of success , converges to the probability density function of the normal distribution with mean $np$ and standard deviation $\sqrt[2]{np(1-p)}$ , as $n$ grows large, assuming $p$ is not $0$ or $1$.
   
    #### Gauss: 
    #### Central limit theorem: 

2. According to [wikipedia](https://en.wikipedia.org/wiki/Marsaglia_polar_method) a common pseudo-random sampling method for generating a pair of independent standard normal random variables is the Marsaglia polar method. This method works by choosing random points $(x,y)$ in the square $-1$ < $x$ < $1$, $-1$ < $y$ < $1$ until
    $0$ < $s=x^2+y^2$ < $1$ ,
    and then returning the required pair of normal random variables as
    $$x\sqrt[2]{\frac{-2ln(s)}{s}},y\sqrt[2]{\frac{-2ln(s)}{s}}$$
    
### Application

1. In order to univocally identify a point in a circle, we can use polar notation. Given a polar angle $\theta$ in the range $[0,2\pi]$ and the length of the hypotenuse in the range $[0, radius]$ a random point inside a circle can be obtained. There is a caveat using this simple method because all the points will be densely distributed near the centre. To avoid such behaviour we use the formula: 

    $$Hypotenuse=\sqrt[2]{r.v.}*radius$$
    
    To convert polar coordinates to cartesian, we obtain the other two legs of the triangle using the sine e cosine function and subtract those values from the coordinates of the centre point.
    
    [Random Points Polar Notation](https://github.com/Ktot0/Statistics/tree/main/week8/Week8_EX1)
    
2. [Simulated Marsaglia Distributions](https://github.com/Ktot0/Statistics/tree/main/week8/Week8_EX2)

### Research on App

1.
