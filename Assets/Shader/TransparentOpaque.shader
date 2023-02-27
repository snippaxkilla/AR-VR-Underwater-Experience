Shader "Custom/TransparentOpaque" {
    Properties {
        _MainTex ("Texture", 2D) = "white" {}
        _Cutoff ("Alpha Cutoff", Range(0,1)) = 0.5
    }
 
    SubShader {
        Tags { "RenderType"="Opaque" }
 
        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
 
            struct appdata {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 uv : TEXCOORD0;
            };
 
            struct v2f {
                float2 uv : TEXCOORD0;
                float3 worldNormal : TEXCOORD1;
                float4 vertex : SV_POSITION;
            };
 
            sampler2D _MainTex;
            float _Cutoff;
 
            v2f vert (appdata v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                o.worldNormal = UnityObjectToWorldNormal(v.normal);
                return o;
            }
 
            fixed4 frag (v2f i) : SV_Target {
                float3 worldNormal = normalize(i.worldNormal);
                float dotProduct = dot(worldNormal, float3(0, 0, -1));
                if (dotProduct < 0) {
                    return tex2D(_MainTex, i.uv);
                } else {
                    return tex2D(_MainTex, i.uv) * (1 - _Cutoff);
                }
            }
            ENDCG
        }
    }
 
    SubShader {
        Tags { "RenderType"="Transparent" }
        LOD 100
 
        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
 
            struct appdata {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 uv : TEXCOORD0;
            };
 
            struct v2f {
                float2 uv : TEXCOORD0;
                float3 worldNormal : TEXCOORD1;
                float4 vertex : SV_POSITION;
            };
 
            sampler2D _MainTex;
            float _Cutoff;
 
            v2f vert (appdata v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                o.worldNormal = UnityObjectToWorldNormal(v.normal);
                return o;
            }
 
            fixed4 frag (v2f i) : SV_Target {
                float3 worldNormal = normalize(i.worldNormal);
                float dotProduct = dot(worldNormal, float3(0, 0, -1));
                if (dotProduct < 0) {
                    return tex2D(_MainTex, i.uv) * (1 - _Cutoff);
                } else {
                    discard;
                    return fixed4(0,0,0,0);
                }
            }
            ENDCG
        }
    }
 
    FallBack "Diffuse"
}

