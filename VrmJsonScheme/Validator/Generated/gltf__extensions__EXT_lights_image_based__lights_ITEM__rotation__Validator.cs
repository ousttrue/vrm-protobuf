﻿// this code is generated. don't modify this code.
using System.Text.Json;

namespace VrmValidator
{

    // .extensions.EXT_lights_image_based.lights[{0}].rotation
    public class gltf__extensions__EXT_lights_image_based__lights_ITEM__rotation__Validator
    {
        ValidationContext m_context;

        public gltf__extensions__EXT_lights_image_based__lights_ITEM__rotation__Validator(ValidationContext context)
        {           
            m_context = context;
        }

        public void Validate(JsonElement json)
        {
            int i=0;
            foreach(var item in json.EnumerateArray())
            {
                m_context.Push(i++);
                
                m_context.Pop();
            }
        }
    }

}
