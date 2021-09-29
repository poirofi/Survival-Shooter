﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeFactory
{
    // use getshape method to get object of type shape
    public Shape getShape(String shapeType)
    {
        if(shapeType == null)
        {
            return null;
        }

        if(shapeType.equalsIgnoreCase("CIRCLE"))
        {
            return new Circle();
        }

        else if(shapeType.equalsIgnoreCase("RECTANGLE"))
        {
            return new Rectangle();
        }

        else if(shapeType.equalsIgnoreCase("SQUARE"))
        {
            return new Square();
        }

        return null;
    }
}
