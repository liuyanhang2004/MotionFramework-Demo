﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using YooAsset.Editor;

public class CollectShaderVariants : IFilterRule
{
	public bool IsCollectAsset(FilterRuleData data)
	{
		return Path.GetExtension(data.AssetPath) == ".shadervariants";
	}
}