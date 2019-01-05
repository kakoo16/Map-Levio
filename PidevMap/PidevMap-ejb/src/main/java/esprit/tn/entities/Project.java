package esprit.tn.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Timestamp;
import java.util.List;


/**
 * The persistent class for the Projects database table.
 * 
 */
@Entity
@Table(name="Projects")
@NamedQuery(name="Project.findAll", query="SELECT p FROM Project p")
public class Project implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="ProjectId")
	private int projectId;

	@Column(name="category_type")
	private String categoryType;

	@Column(name="end_date")
	private Timestamp endDate;

	@Column(name="levio_number_ressources")
	private int levioNumberRessources;

	private String picture;

	@Column(name="project_name")
	private String projectName;

	@Column(name="project_type")
	private int projectType;

	@Column(name="start_date")
	private Timestamp startDate;

	@Column(name="total_number_ressources")
	private int totalNumberRessources;

	//bi-directional many-to-one association to Mandate
	@OneToMany(mappedBy="project")
	private List<Mandate> mandates;

	//bi-directional many-to-one association to Address
	@ManyToOne
	@JoinColumn(name="addresse_AddressId")
	private Address address;

	//bi-directional many-to-one association to Clientnotapproved
	@ManyToOne
	@JoinColumn(name="MyClient_ClientId")
	private Clientnotapproved clientnotapproved;

	//bi-directional many-to-one association to Organizational_Chart
	@ManyToOne
	@JoinColumn(name="MyOrgChart_ChartId")
	private Organizational_Chart organizationalChart;

	//bi-directional many-to-one association to RessourceN
	@ManyToOne
	@JoinColumn(name="RessourceN_RessourceId")
	private RessourceN ressourceN;

	//bi-directional many-to-one association to Skill
	@ManyToOne
	@JoinColumn(name="SkillFk_SkillId")
	private Skill skill;

	public Project() {
	}

	public int getProjectId() {
		return this.projectId;
	}

	public void setProjectId(int projectId) {
		this.projectId = projectId;
	}

	public String getCategoryType() {
		return this.categoryType;
	}

	public void setCategoryType(String categoryType) {
		this.categoryType = categoryType;
	}

	public Timestamp getEndDate() {
		return this.endDate;
	}

	public void setEndDate(Timestamp endDate) {
		this.endDate = endDate;
	}

	public int getLevioNumberRessources() {
		return this.levioNumberRessources;
	}

	public void setLevioNumberRessources(int levioNumberRessources) {
		this.levioNumberRessources = levioNumberRessources;
	}

	public String getPicture() {
		return this.picture;
	}

	public void setPicture(String picture) {
		this.picture = picture;
	}

	public String getProjectName() {
		return this.projectName;
	}

	public void setProjectName(String projectName) {
		this.projectName = projectName;
	}

	public int getProjectType() {
		return this.projectType;
	}

	public void setProjectType(int projectType) {
		this.projectType = projectType;
	}

	public Timestamp getStartDate() {
		return this.startDate;
	}

	public void setStartDate(Timestamp startDate) {
		this.startDate = startDate;
	}

	public int getTotalNumberRessources() {
		return this.totalNumberRessources;
	}

	public void setTotalNumberRessources(int totalNumberRessources) {
		this.totalNumberRessources = totalNumberRessources;
	}

	public List<Mandate> getMandates() {
		return this.mandates;
	}

	public void setMandates(List<Mandate> mandates) {
		this.mandates = mandates;
	}

	public Mandate addMandate(Mandate mandate) {
		getMandates().add(mandate);
		mandate.setProject(this);

		return mandate;
	}

	public Mandate removeMandate(Mandate mandate) {
		getMandates().remove(mandate);
		mandate.setProject(null);

		return mandate;
	}

	public Address getAddress() {
		return this.address;
	}

	public void setAddress(Address address) {
		this.address = address;
	}

	public Clientnotapproved getClientnotapproved() {
		return this.clientnotapproved;
	}

	public void setClientnotapproved(Clientnotapproved clientnotapproved) {
		this.clientnotapproved = clientnotapproved;
	}

	public Organizational_Chart getOrganizationalChart() {
		return this.organizationalChart;
	}

	public void setOrganizationalChart(Organizational_Chart organizationalChart) {
		this.organizationalChart = organizationalChart;
	}

	public RessourceN getRessourceN() {
		return this.ressourceN;
	}

	public void setRessourceN(RessourceN ressourceN) {
		this.ressourceN = ressourceN;
	}

	public Skill getSkill() {
		return this.skill;
	}

	public void setSkill(Skill skill) {
		this.skill = skill;
	}

}