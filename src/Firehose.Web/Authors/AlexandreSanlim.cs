using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
	public class AlexandreSanlim : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Alexandre";
		public string LastName => "Sanlim";
		public string ShortBioOrTagLine => "I Love mobile design and open source solutions";
		public string StateOrRegion => "Curitiba, Brasil";
		public string EmailAddress => "alexandreslima@outlook.com";
		public string TwitterHandle => "alexandresanlim";
		public string GitHubHandle => "alexandresanlim";
		public string GravatarHash => "201e2428b23bfe48fbb3e02e54f6652d";
		public GeoPosition Position => new GeoPosition(-25.433358,-49.263427);
		public Uri WebSite => new Uri("https://alexandresanlim.github.io/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://medium.com/feed/xamarinbrasil"); } }
		public string FeedLanguageCode => "pt";

		public bool Filter(SyndicationItem item)
		{
			//This blog is solely about Xamarin
			return true;
		}
	}
}