#define STB_IMAGE_IMPLEMENTATION
#define STB_IMAGE_WRITE_IMPLEMENTATION
#define STB_DXT_IMPLEMENTATION
#define STB_IMAGE_RESIZE_IMPLEMENTATION
#define STB_PERLIN_IMPLEMENTATION
#define STB_RECT_PACK_IMPLEMENTATION

#if defined _WIN32 || defined __CYGWIN__
#ifdef CIMGUI_NO_EXPORT
#define API
#else
#define API __declspec(dllexport)
#endif
#else
#ifdef __GNUC__
#define API __attribute__((__visibility__("default")))
#else
#define API
#endif
#endif

#if defined __cplusplus
#define EXTERN extern "C"
#else
#include <stdarg.h>
#include <stdbool.h>
#define EXTERN extern
#endif

#define STBIDEF EXTERN API
#define STBIWDEF EXTERN API
#define STBIRDEF EXTERN API
#define STBRP_DEF EXTERN API
#define STBSP__PUBLICDEC EXTERN API
#define STBTT_DEF EXTERN API
#define STBVXDEC EXTERN API

#define STB_API EXTERN API

#include "stb/stb_image.h"
#include "stb/stb_image_write.h"
#include "stb/stb_dxt.h"
#include "stb/stb_image_resize2.h"
#include "stb/stb_perlin.h"
#include "stb/stb_rect_pack.h"
#include "stb/stb_textedit.h"
#include "stb/stb_truetype.h"
#include "stb/stb_voxel_render.h"
#include "stb/stb_herringbone_wang_tile.h"
#include "stb/stb_divide.h"
#include "stb/stb_connected_components.h"
#include "stb/stb_easy_font.h"
