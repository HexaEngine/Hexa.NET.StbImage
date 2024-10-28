﻿// See https://aka.ms/new-console-template for more information
using Hexa.NET.GLFW;
using Hexa.NET.ImGui;
using Hexa.NET.ImGui.Backends.GLFW;
using Hexa.NET.ImGui.Backends.OpenGL3;
using Hexa.NET.OpenGL;
using Hexa.NET.StbImage;
using HexaGen.Runtime;
using System.Runtime.CompilerServices;
using GLFWwindowPtr = Hexa.NET.GLFW.GLFWwindowPtr;

GLFW.Init();

string glslVersion = "#version 330 core";
GLFW.WindowHint(GLFW.GLFW_CONTEXT_VERSION_MAJOR, 3);
GLFW.WindowHint(GLFW.GLFW_CONTEXT_VERSION_MINOR, 3);
GLFW.WindowHint(GLFW.GLFW_OPENGL_PROFILE, GLFW.GLFW_OPENGL_CORE_PROFILE);  // 3.2+ only

GLFW.WindowHint(GLFW.GLFW_FOCUSED, 1);    // Make window focused on start
GLFW.WindowHint(GLFW.GLFW_RESIZABLE, 1);  // Make window resizable

GLFWwindowPtr window = GLFW.CreateWindow(800, 600, "GL ImGui Example", null, null);
if (window.IsNull)
{
    Console.WriteLine("Failed to create GLFW window.");
    GLFW.Terminate();
    return;
}

GLFW.MakeContextCurrent(window);
GL.InitApi(new BindingsContext());

var guiContext = ImGui.CreateContext();
ImGui.SetCurrentContext(guiContext);

// Setup ImGui config.
var io = ImGui.GetIO();
io.ConfigFlags |= ImGuiConfigFlags.NavEnableKeyboard;     // Enable Keyboard Controls
io.ConfigFlags |= ImGuiConfigFlags.NavEnableGamepad;      // Enable Gamepad Controls
io.ConfigFlags |= ImGuiConfigFlags.DockingEnable;         // Enable Docking
io.ConfigFlags |= ImGuiConfigFlags.ViewportsEnable;       // Enable Multi-Viewport / Platform Windows
io.ConfigViewportsNoAutoMerge = false;
io.ConfigViewportsNoTaskBarIcon = false;

ImGuiImplGLFW.SetCurrentContext(guiContext);

if (!ImGuiImplGLFW.InitForOpenGL(Unsafe.BitCast<GLFWwindowPtr, Hexa.NET.ImGui.Backends.GLFW.GLFWwindowPtr>(window), true))
{
    Console.WriteLine("Failed to init ImGui Impl GLFW");
    GLFW.Terminate();
    return;
}

ImGuiImplOpenGL3.SetCurrentContext(guiContext);
if (!ImGuiImplOpenGL3.Init(glslVersion))
{
    Console.WriteLine("Failed to init ImGui Impl OpenGL3");
    GLFW.Terminate();
    return;
}

uint texture;
unsafe
{
    int width = 0, height = 0, channels = 0;
    var img = StbImage.Load("icon.png", ref width, ref height, ref channels, 0);

    if (img == null)
    {
        Console.WriteLine("Failed to load image!");
        return;
    }
    // Generate OpenGL texture
    texture = GL.GenTexture();
    GL.BindTexture(GLTextureTarget.Texture2D, texture);

    // Set texture parameters
    GL.TexParameteri(GLTextureTarget.Texture2D, GLTextureParameterName.WrapS, (int)GLTextureWrapMode.Repeat);
    GL.TexParameteri(GLTextureTarget.Texture2D, GLTextureParameterName.WrapT, (int)GLTextureWrapMode.Repeat);
    GL.TexParameteri(GLTextureTarget.Texture2D, GLTextureParameterName.MinFilter, (int)GLTextureMinFilter.Linear);
    GL.TexParameteri(GLTextureTarget.Texture2D, GLTextureParameterName.MagFilter, (int)GLTextureMagFilter.Linear);

    // Upload texture data to OpenGL
    var format = channels == 4 ? GLPixelFormat.Rgba : GLPixelFormat.Rgb;
    GL.TexImage2D(GLTextureTarget.Texture2D, 0, GLInternalFormat.Rgba, width, height, 0, format, GLPixelType.UnsignedByte, img);

    // Generate mipmaps
    GL.GenerateMipmap(GLTextureTarget.Texture2D);

    // Free image data
    StbImage.ImageFree(img);
}

// Main loop
while (GLFW.WindowShouldClose(window) == 0)
{
    // Poll for and process events
    GLFW.PollEvents();

    if (GLFW.GetKey(window, (int)GlfwKey.Escape) == GLFW.GLFW_PRESS)
    {
        GLFW.SetWindowShouldClose(window, 1); // Request to close the window
    }

    GLFW.MakeContextCurrent(window);
    GL.ClearColor(1, 0.8f, 0.75f, 1);
    GL.Clear(GLClearBufferMask.ColorBufferBit);

    ImGuiImplOpenGL3.NewFrame();
    ImGuiImplGLFW.NewFrame();
    ImGui.NewFrame();

    ImGui.Image((ImTextureID)(long)texture, new(256));

    ImGui.Render();
    ImGui.EndFrame();

    GLFW.MakeContextCurrent(window);
    ImGuiImplOpenGL3.RenderDrawData(ImGui.GetDrawData());

    if ((io.ConfigFlags & ImGuiConfigFlags.ViewportsEnable) != 0)
    {
        ImGui.UpdatePlatformWindows();
        ImGui.RenderPlatformWindowsDefault();
    }

    GLFW.MakeContextCurrent(window);

    // Swap front and back buffers (double buffering)
    GLFW.SwapBuffers(window);
}

// Clean up and terminate GLFW
GLFW.DestroyWindow(window);
GLFW.Terminate();

internal unsafe class BindingsContext : INativeContext
{
    public void Dispose()
    {
    }

    public nint GetProcAddress(string procName)
    {
        return (nint)GLFW.GetProcAddress(procName);
    }

    public bool IsExtensionSupported(string extensionName)
    {
        return GLFW.ExtensionSupported(extensionName) != 0;
    }

    public bool TryGetProcAddress(string procName, out nint procAddress)
    {
        procAddress = GetProcAddress(procName);
        return procAddress != 0;
    }
}