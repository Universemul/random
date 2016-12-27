#ifndef SIM_OBJECT_H
#define SIM_OBJECT_H
/* This class provides the interface for all of simulation objects. It also stores the
object's name, and has pure virtual accessor functions for the object's position
and other information.  */

#include <string>
#include <iostream>	// demonstration only

#include "Component.h"
#include "Geometry.h"
#include "Utility.h"

class Sim_object : public Component
{
public:
	Sim_object(const std::string& name_) : 
		name(name_)
		{ }

	// *** declare the destructor appropriately and use the following function body
	virtual ~Sim_object()
		{ }
	
	std::string get_name() const
		{return name;}
		
	/*** Interface for derived classes ***/
	virtual Point get_location() const = 0;
	virtual void describe() const = 0;
	virtual void update() = 0;

    /*** Fat interface for grouping objects ***/
    virtual void set_destination_position_and_speed(Point destination_position, double speed)
    { throw Error("Cannot set destination position and speed\n"); }
	virtual void set_course_and_speed(double course, double speed)
    { throw Error("Cannot set course and speeed\n"); }
	virtual void stop()
    { throw Error("Cannot stop\n"); }
	
private:
	std::string name;
};


#endif
