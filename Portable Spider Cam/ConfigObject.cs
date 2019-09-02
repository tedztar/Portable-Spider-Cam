using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortableSpiderCam
{
    class ConfigObject
    {

        // 1. PROPERTIES. (ALLOWS THE CLASS TO RECOGNISE THESE PASSED VARIABLE NAMES.)

        private int run_speed;
        private int max_x;
        private int max_y;
        private int max_z;
        private int camera_a;
        private int max_movement_speed;

        private int drum_radius;
        private int drum_gear;
        private int motor_gear;

        // 2. CONSTRUCTOR. (ASSIGNS THE VALUES TO ITSELF: THE OBJECT.)

        public ConfigObject(int run_speed, int max_x, int max_y, int max_z, int camera_a,
            int max_movement_speed, int drum_radius, int drum_gear, int motor_gear)
        {

            //Put higher if computer is slow, movement will be less smooth. 
            //Put lower if computer is not lagging, movement will be more smooth.
            this.run_speed = run_speed;
            
            //Set as the width (in cm) of the "box" that the camera can fly in.
            this.max_x = max_x;

            //#Set as the length (in cm) of the "box" that the camera can fly in.
            this.max_y = max_y;

            //Set as the hight (in cm) of the "box" that the camera can fly in.
            this.max_z = max_z;

            //Set as half the width (in cm) of the mount connected to the wires.
            this.camera_a = camera_a;

            //Set as the speed (in cm/s) of the camera.
            this.max_movement_speed = max_movement_speed;



            //Set as the radious (in cm) of the drum for the winch stations.
            this.drum_radius = drum_radius;

            //Set as the number of gears that the drum of the winch has (set to 1 if direct drive.)
            this.drum_gear = drum_gear;

            //Set as the number of gears that the motor of the winch has (set to 1 if direct drive.)
            this.motor_gear = motor_gear;

        }

        // 3. METHODS. (PROVIDE FUNCTIONS WHICH CAN BE USED THROUGHOUT THE MAIN CODE.)

        public int GetRun_Speed()
        {
            return this.run_speed;
        }

        public int GetMax_X()
        {
            return this.max_x;
        }

        public int GetMax_Y()
        {
            return this.max_y;
        }

        public int GetMax_Z()
        {
            return this.max_z;
        }

        public int GetCamera_A()
        {
            return this.camera_a;
        }

        public int GetMax_Movement_Speed()
        {
            return this.max_movement_speed;
        }

        public int GetDrum_Radius()
        {
            return this.drum_radius;
        }

        public int GetDrum_Gear()
        {
            return this.drum_gear;
        }

        public int GetMotor_Gear()
        {
            return this.motor_gear;
        }
    }
}