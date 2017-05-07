# XinAnJiang Model
## Overview
Xin'anjiang model is a hydrological model, which is one of the rare hydrological models with world-wide influence, proposed by Hohai University.
</br>It is a dispersive model that can be used in humid areas of humid and sub-humid areas.
## Features
In this project, the Three - layer Evapotranspiration Model is used to calculate the evaportranspiration, and I use the watershed water storage capacity curve to calculate run-off.
</br>Two runoffs-type division and Three run-offs type division are introduced in this project, but wehn given wrong params, the three run-offs type calculation cant satisfy the water-balance equation.
</br>And in slope convergence, only the linear reservoir method and unit-hydrograph method is adopted.
</br>In river convergence, I use the Muskingum method to compute the final flow rate in watershed export section
## Dependencies
DevExpress
</br>NPOI
## Contact
[My Blog](https://edlinus.cn)