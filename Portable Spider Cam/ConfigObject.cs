using System.Collections.Generic;

namespace WindowsFormsApp1
{
    class ConfigObject
    {
        // Properties. 
        private string file_Name;

        private int run_speed;
        private int max_x;
        private int max_y;
        private int max_z;
        private int camera_a;
        private int max_movement_speed;

        private int drum_radius;
        private int drum_gear;
        private int motor_gear;

        // Constructors.
        public ConfigObject(string file_Name, List<int> file_Config)
        {
            //This is the name of the file.
            this.file_Name = file_Name;

            /* Put higher if computer is slow, movement will be less smooth. 
            Put lower if computer is not lagging, movement will be more smooth.*/
            this.run_speed = file_Config[0];

            // Set as the width (in cm) of the "box" that the camera can fly in.
            this.max_x = file_Config[1];

            // Set as the length (in cm) of the "box" that the camera can fly in.
            this.max_y = file_Config[2];

            // Set as the hight (in cm) of the "box" that the camera can fly in.
            this.max_z = file_Config[3];

            // Set as half the width (in cm) of the mount connected to the wires.
            this.camera_a = file_Config[4];

            // Set as the speed (in cm/s) of the camera.
            this.max_movement_speed = file_Config[5];



            // Set as the radious (in cm) of the drum for the winch stations.
            this.drum_radius = file_Config[6];

            // Set as the number of gears that the drum of the winch has (set to 1 if direct drive.)
            this.drum_gear = file_Config[7];

            // Set as the number of gears that the motor of the winch has (set to 1 if direct drive.)
            this.motor_gear = file_Config[8];

        }


        // Methods.
        public string get_File_Name()
        {
            return this.file_Name;
        }

        public int get_Run_Speed()
        {
            return this.run_speed;
        }

        public int get_Max_X()
        {
            return this.max_x;
        }

        public int get_Max_Y()
        {
            return this.max_y;
        }

        public int get_Max_Z()
        {
            return this.max_z;
        }

        public int get_Camera_A()
        {
            return this.camera_a;
        }

        public int get_Max_Movement_Speed()
        {
            return this.max_movement_speed;
        }

        public int get_Drum_Radius()
        {
            return this.drum_radius;
        }

        public int get_Drum_Gear()
        {
            return this.drum_gear;
        }

        public int get_Motor_Gear()
        {
            return this.motor_gear;
        }

        public List<int> get_Config()
        {
            return new List<int>() {
                this.run_speed,
                this.max_x,
                this.max_y,
                this.max_z,
                this.camera_a,
                this.max_movement_speed,
                this.drum_radius,
                this.drum_gear,
                this.motor_gear
            };
        }
    }
}
