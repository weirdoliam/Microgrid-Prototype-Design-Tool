﻿// This file was auto-generated by ML.NET Model Builder.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using Microsoft.ML;

namespace WinFormsApp1
{
    public partial class MLModel1
    {
        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process. For more information on how to load data, see aka.ms/loaddata.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainPipeline(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Categorical.OneHotEncoding(new []{new InputOutputColumnPair(@"heatpump", @"heatpump"),new InputOutputColumnPair(@"electric_cooking", @"electric_cooking"),new InputOutputColumnPair(@"gas_cooking", @"gas_cooking"),new InputOutputColumnPair(@"bottled_gas_cooking", @"bottled_gas_cooking"),new InputOutputColumnPair(@"electric_water_heating", @"electric_water_heating"),new InputOutputColumnPair(@"gas_water_heating", @"gas_water_heating"),new InputOutputColumnPair(@"wood_water_heating", @"wood_water_heating"),new InputOutputColumnPair(@"electric_heating", @"electric_heating"),new InputOutputColumnPair(@"gas_heating", @"gas_heating"),new InputOutputColumnPair(@"wood_heating", @"wood_heating"),new InputOutputColumnPair(@"fossil_fuels_heating", @"fossil_fuels_heating")}, outputKind: OneHotEncodingEstimator.OutputKind.Indicator)      
                                    .Append(mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"adults", @"adults"),new InputOutputColumnPair(@"children", @"children"),new InputOutputColumnPair(@"datetime", @"datetime")}))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"heatpump",@"electric_cooking",@"gas_cooking",@"bottled_gas_cooking",@"electric_water_heating",@"gas_water_heating",@"wood_water_heating",@"electric_heating",@"gas_heating",@"wood_heating",@"fossil_fuels_heating",@"adults",@"children",@"datetime"}))      
                                    .Append(mlContext.Transforms.NormalizeMinMax(@"Features", @"Features"))      
                                    .Append(mlContext.Regression.Trainers.FastTreeTweedie(new FastTreeTweedieTrainer.Options(){NumberOfLeaves=617,MinimumExampleCountPerLeaf=19,NumberOfTrees=398,MaximumBinCountPerFeature=1022,FeatureFraction=0.917003071507875,LearningRate=0.0320551662432408,LabelColumnName=@"consumpiton_data",FeatureColumnName=@"Features"}));

            return pipeline;
        }
    }
}