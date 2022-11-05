
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


# Week 5


## Objectives:

* Research

1. Explain all possible derivation of the arithmetic mean and in general of the other common types of averages
2. Illustrate the difference between "mathematical convergence" and "convergence" in probability
3. Illustrate the differences between Descriptive Statistics and Inferential Statistics and the role of probability and probability distributions

* Application

1. Given an arbitrary rectangle and a distribution, create the corresponding histogram or column chart, with both vertical and horizontal orientation
2. Given a rectangle, enable its movement/resize/zoom using a mouse (this will be the resizable where we will draw alll future charts)

* Research on App

## Assignment
### Research

1. Explain all possible derivation of the arithmetic mean and in general of the other common types of averages.

* #### Geometric Mean

    The geometric mean is a mean which indicates the central tendency of a set of numbers using their product, while the arithmetic mean uses their sum. It is  particularly useful when dealing with numbers that need to be multiplied or numbers that are exponential.
    
    $$(\prod_{i=1}^{n} x_1)^{1/n}=\sqrt[n]{x_1 x_2 ... x_n}$$

* #### Harmonic Mean

    The harmonic mean is a particular kind of Pythagorean mean.  It can be expressed as the reciprocal of the arithmetic mean of the reciprocal of all observations.
    
    $$H = \frac{n}{\frac{1}{x_1}+\frac{1}{x_2}+...+\frac{1}{x_n}}$$

* #### Power Mean

    If $p$ is a non-zero real number, and $x_1,...,x_n$ are positive real numbers their power mean is:

    $$M_p(x_1,...,x_n)=(\frac{1}{n}\sum_{i=1}^{n}{x_i^p})^{1/p}$$


2. Illustrate the difference between "mathematical convergence" and "convergence" in probability.
 
* #### Convergence in probability:
 
    Convergence in probability is the type of convergence established by the weak law of large numbers. Two random variables are "close to each other" if there is a high probability that their difference is very small.

* #### Convergence in distribution: 
    Convergence in distribution is the weakest form of convergence since it is implied by all other types of convergence but is very frequently used in practice. Using this mode of convergence we expect the model to become more accurate for each next outcome of a random experiment. 

3. Illustrate the differences between Descriptive Statistics and Inferential Statistics and the role of probability and probability distributions.

* #### Descriptive statistics: 
    Descriptive statistics allow us to summarize data in a more transparent way. It can not provide a prevision of future behaviours based on data analysis. Typically, Measures of central tendency and Measures of spread are used to describe data.

* #### Inferential statistics: 
    Inferential statistics are techniques that allow us to use samples to make generalizations about the populations when it is not feasible to gather or analyse the whole population. The chosen sample needs to represent correctly the entire population.

### App


[Arbitrary distribution](https://github.com/Ktot0/Statistics/tree/main/week5/Week5_EX1)

[Rectangle resize](https://github.com/Ktot0/Statistics/tree/main/week5/Week5_EX2)

### Research on App


