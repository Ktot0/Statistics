
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


# Week 6


## Objectives:

* Research

1. Try to explain in your own words the concept of population and sampling distribution
2. Show the expected value and variance of the sampling mean and take a look at the same sampling variance

* Application

1. Take any population and any variable X and draw m (large) samples of size n (as you like) and represent the following 2 distributions: Distribution of the mean and distribution of the variance. Finally, for each distribution compute mean and variance and compare the corrisponding values in the population.

* Research on App

## Assignment
### Research

1. Try to explain in your own words the concept of population and sampling distribution

    In statistics, we refer to a population as a complete set of individuals with a common characteristic, while a sample is a smaller portion of said population extracted using sampling techniques. A sample must reflect its original population characteristics. For this reason, a statistical analysis of a sample must report the approximate standard deviation, or standard error, of its results from the entire population. 
A sampling distribution is a probability distribution of a statistic obtained from a larger set of samples drawn from a specific population. The sampling distribution of a given population is the distribution of frequencies of a range of different outcomes that could occur for a statistic of a population. As an example, we consider a population with mean and variance. We continuously take samples of size N and calculate the arithmetic mean for each sample or sample mean. We call "sampling distribution of the sample means" the distribution of the sample means.

2. Show the expected value and variance of the sampling mean and take a look at the same sampling variance

    The expected value is calculated by multiplying each of the possible outcomes by the likelihood that each outcome will occur and then summing all of those values.

    $$EV=\sum {P(X_i)\times X_i}$$

    Where
    * X is a random variable.
    * P(X) is the probability of the random variable
    
    The variance of the sampling distribution of the mean is the population variance divided by the sample size. 
        
    $$\sigma _M^2 = \frac{\sigma^2}{N}$$
        
    The larger the sample size, the smaller the variance of the sampling distribution of the mean.
    Instead, the expected value of the sample mean is the population mean.

### Application

[Exercise 1](https://github.com/Ktot0/Statistics/tree/main/week6/Week6_EX1)

