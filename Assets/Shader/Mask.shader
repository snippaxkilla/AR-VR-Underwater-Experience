Shader "Custom/Masking"
{
    Properties
    {
       
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" }
        
        Pass {
            Zwrite Off    
        }
    }
}
