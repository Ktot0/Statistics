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

1. Consider X (radius), Y (angle) uniform r.vs. and use them to determine points on a plane as image. Determine the empirical distribution of the Cartesian coordinates (Application). Search on the web about this problem.
2. Search for the methods to generate a NORMAL r.v. $X$, and simulate (Application) the following distribution: $X$, $X^2$ , $X/Y^2$, $X^2/Y^2$, $X/Y$.


## Assignment
### Research

1. In order to univocally identify a point in a circle, we can use polar notation. Given a polar angle $\theta$ in the range $[0,2\pi]$ and the length of the hypotenuse in the range $[0, radius]$ a random point inside a circle can be obtained. There is a caveat using this simple method because all the points will be densely distributed near the centre. To avoid such behaviour we use the formula: 

    $$Hypotenuse=\sqrt[2]{r.v.}*radius$$
    
    To convert polar coordinates to cartesian, we obtain the other two legs of the triangle using the sine e cosine function and subtract those values from the coordinates of the centre point.
    
2. According to [wikipedia](https://en.wikipedia.org/wiki/Marsaglia_polar_method) a common pseudo-random sampling method for generating a pair of independent standard normal random variables is the Marsaglia polar method.

