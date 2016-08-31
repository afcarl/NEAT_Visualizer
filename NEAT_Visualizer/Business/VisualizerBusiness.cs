﻿using NEAT_Visualizer.Business.DataLoaders;

namespace NEAT_Visualizer.Business
{
  public class VisualizerBusiness : IVisualizerBusiness
  {
    public VisualizerBusiness(INetworkLoader networkLoader)
    {
      NetworkLoader = networkLoader;
    }

    public INetworkLoader NetworkLoader { get; }
  }
}