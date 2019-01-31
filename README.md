# Proof Productions

Our theater automation system allows for the configuration of motors and other cues during a play. The computer is connected to all of the motors in the theater and the user can schedule different cues for each scene in a play. This application was developed for our Software Engineering class in Fall 2017.

Product Owner: [Stephen Canzanese](https://github.com/stephencanzanese)  
Scrum Master: [Joshua DeNoble](https://github.com/denoblej9)  
Dev Team: [Tyler Carberry](https://github.com/TylerCarberry), [Benny Liang](https://github.com/liangb6), [Wen Cao](https://github.com/caow2), and [Tom Abraham](https://github.com/abrahamt0)

## Details

A computer running Windows can control motors through the use of ModbusTCP. Modbus information such as speed, acceleration, and deceleration are sent to a motor and the motor will return data that shows its current values. The computer is connected to a programmable logic controller (PLC) which can connect to multiple motors. The PLC acts like a switch to the motors that it is connected to. Additionally, each motor is connected to a encoder which provides an electrical signal that is used for speed and/or position control and one or more limit switches that stops a motor when passed. The system also has a emergency stop button to cease all motor functions if necessary.

## Screenshots

<img width="600" alt="Home" src="https://user-images.githubusercontent.com/6628497/52029068-b2591400-24df-11e9-8b66-b69451493000.png">

<img width="390" alt="Setup Cue" src="https://user-images.githubusercontent.com/6628497/52029094-c270f380-24df-11e9-94d3-5c2074beb643.png"><img width="375" alt="Setup Motors" src="https://user-images.githubusercontent.com/6628497/52029078-b7b65e80-24df-11e9-89d9-894389f78386.png">

